using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Automacao.Common.Utilities.EffectsForm;
using ThreadState = System.Threading.ThreadState;

namespace Automacao.DisparaBat
{
    public partial class Form1 : Form
    {
        private static List<Color> _selectedColors;
        private Thread thread;

        public Form1()
        {
            
            InitializeComponent();
            _selectedColors = new List<Color>();
        }

        #region ◄ Panel 1 ►

        private void btnSelecionarCaminho_Click(object sender, EventArgs e)
        {
            var resultDialog = folderBrowserDialog1.ShowDialog();

            if (resultDialog == DialogResult.OK)
                txtCaminho.Text = folderBrowserDialog1.SelectedPath;

        }

        public void AddRowGrid(string nameFile, string folder, string path, Color color)
        {
            Invoke(new Action(() =>
            {
                dataGridViewFiles.Rows
               .Add(false, nameFile.Split('.')[0], nameFile.Split('.')[1], folder, path);

                dataGridViewFiles.Rows[dataGridViewFiles.Rows.Count - 1].Cells[3].Style.BackColor = color;
            }));
        }

        public void GetFolders(string dir)
        {
            var folders = Directory.GetDirectories(dir);

            if (!folders.Any())
                return;

            foreach (string folder in folders)
            {
                GetFolders(folder);
                GetFileInFolder(folder);
            }

        }

        public void GetFileInFolder(string dir)
        {
            var color = new Color();
            var folder = string.Empty;
            var fileName = string.Empty;
            var folderOld = "";

            foreach (string pathFile in Directory.GetFiles(dir))
            {
                if (!pathFile.Contains(".bat") && !pathFile.Contains(".exe"))
                    continue;

                folder = pathFile.Split('\\')[pathFile.Split('\\').Length - 2];
                fileName = pathFile.Split('\\')[pathFile.Split('\\').Length - 1];

                if (folderOld != folder) 
                { 
                    color = GetColorRandom();
                    folderOld = folder;
                }

                AddRowGrid(fileName, folder, pathFile, color);
            }
        }

        private Color GetColorRandom()
        {
            KnownColor[] names;
            Color colorSorted;
            int colorNumber;

            while (true)
            {
                colorNumber = new Random().Next(0, _allColors.Count());
                colorSorted = ColorTranslator.FromHtml(_allColors[colorNumber]);

                if(_selectedColors.All(x => x.Name != colorSorted.Name))
                    break;
            }

            _selectedColors.Add(colorSorted);
            return colorSorted;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            var rowsMarcadas = (from DataGridViewRow r in dataGridViewFiles.Rows
                                where Convert.ToBoolean(r.Cells[0].Value)
                                select r).ToList();

            if (!rowsMarcadas.Any())
            {
                MessageBox.Show("Selecione ao menos um arquivo.",
                    "Dispara Execução informa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in rowsMarcadas)
            {
                dataGridExecucao.Rows.Add(
                    row.Cells[1].Value,
                    row.Cells[2].Value,
                    row.Cells[3].Value,
                    row.Cells[4].Value
                );
            }

            ShowHide(panel1);
            ShowHide(panel2);
        }

        private void btnBuscarFiles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaminho.Text))
            {
                MessageBox.Show("Nenhum caminho selecionado.",
                    "Dispara Execução informa.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dataGridViewFiles.Rows.Clear();
                _selectedColors.Clear();

                UseWaitCursor = true;
                Cursor.Current = Cursors.WaitCursor;

                btnBuscarFiles.Visible = false;
                txtCaminho.Enabled = false;

                thread = new Thread(x =>
                {
                    try
                    {
                        GetFileInFolder(txtCaminho.Text);
                        GetFolders(txtCaminho.Text);
                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() =>
                        {
                            MessageBox.Show(ex.Message, "Ocorreu um erro ao buscar arquivos",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            
                            dataGridViewFiles.Rows.Clear();
                        }));
                    }
                    finally
                    {
                        Invoke(new Action(() =>
                        {
                            UseWaitCursor = false;
                            Cursor.Current = Cursors.Default;
                            btnProximo.Visible = true;
                            btnBuscarFiles.Visible = true;
                            txtCaminho.Enabled = true;
                        }));
                    }
                });

                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao buscar arquivos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
            }
        }

        #endregion

        #region ◄ Panel 2 ►

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var rowsExecucao = dataGridExecucao.Rows;

            new Thread(x =>
            {
                foreach (DataGridViewRow row in rowsExecucao)
                {
                    row.Selected = true;

                    row.DefaultCellStyle.BackColor = ExecuteFile(row.Cells[3].Value.ToString())
                        ? Color.Aquamarine
                        : Color.Tomato;
                    
                    Thread.Sleep(1000);

                    row.Selected = false;
                }
            }).Start();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            dataGridExecucao.Rows.Clear();
            ShowHide(panel2);
            ShowHide(panel1);
        }

        private bool ExecuteFile(string pathFile)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = pathFile;
            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region ◄ Commum ►

        private void ShowHide(Control componente)
        {
            EffectTransition.Animate(componente, EffectTransition.Effect.Slide, 150, 180);
        }

        public static string[] _allColors = {
            "#7B68EE","#9370DB","#9400D3","#87CEFA","#FA8072",
            "#FF0000" , "#FF4500", "#2E8B57","#DEB887","#CD853F",
            "#B22222","#32CD32","#66CDAA"
        };
        #endregion
    }
}
