using System;
using System.Deployment.Application;
using System.Windows.Forms;
using WordProcessor;

namespace Imlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String latin = Cyr2Lat(richTextBox1.Text);
            richTextBox2.Text = latin;
            Clipboard.SetText(latin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String cyrillic = TextHelper.LatToCyr(richTextBox2.Text);
            richTextBox1.Text = cyrillic;
            Clipboard.SetText(cyrillic);
        }

        public static string Cyr2Lat(string str)
        {
            string[] lat_up = { "A", "B", "V", "G", "D", "E", "Yo", "J", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "X", "Ts", "Ch", "Sh", "Sh", "'", "Y", "'", "E", "Yu", "Ya", "O'", "Q", "G'", "H"};
            string[] lat_low = { "a", "b", "v", "g", "d", "e", "yo", "j", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "x", "ts", "ch", "sh", "sh", "'", "y", "'", "e", "yu", "ya", "o'", "q", "g'", "h"};
            string[] rus_up = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я", "Ў", "Қ", "Ғ", "Ҳ" };
            string[] rus_low = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", "ў", "қ", "ғ", "ҳ" };
            for (int i = 0; i <= 36; i++)
            {
                str = str.Replace(rus_up[i], lat_up[i]);
                str = str.Replace(rus_low[i], lat_low[i]);
            }
            return str;
        }

        private void mavjudFaylniOchishToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 infoform = new Form2();
            infoform.ShowDialog();
        }

        private void yangilanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstallUpdateSyncWithInfo();
        }

        private void InstallUpdateSyncWithInfo()
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();

                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("Yangi versiyani ko'chirib olishni imkoni bo'lmadi. \n\nIltimos internet mavjudligini tekshiring. Xatolik: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Cannot check for a new version of the application. The ClickOnce deployment is corrupt. Please redeploy the application and try again. Error: " + ide.Message);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " + ioe.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel);
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("This application has detected a mandatory update from your current " +
                            "version to version " + info.MinimumRequiredVersion.ToString() +
                            ". The application will now install the update and restart.",
                            "Update Available", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            MessageBox.Show("The application has been upgraded, and will now restart.");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("Cannot install the latest version of the application. \n\nPlease check your network connection, or try again later. Error: " + dde);
                            return;
                        }
                    }
                }
            }
        }
        
        private void clearText1(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Equals("Кирил алифбосидаги матнни шу ерга киритинг"))
            {
                richTextBox1.Text = "";
            }
        }

        private void clearText2(object sender, EventArgs e)
        {
            if(richTextBox2.Text.Equals("Lotin alifbosidagi matnni shu yerga kiriting"))
            {
                richTextBox2.Text = "";
            }
        }
    }
}
