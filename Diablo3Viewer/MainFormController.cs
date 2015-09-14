using Diablo3Viewer.DataFetcher;
using Diablo3Viewer.DataInterpreters;
using Diablo3Viewer.DataModels;
using Diablo3Viewer.TabPageCreators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diablo3Viewer
{
    class MainFormController
    {
        private CareerProfileData cpd;
        private List<CharacterData> chdata;
        private TabControl tabControl;
        private ProgressBarDisplay progressForm;

        private Boolean progressBarRunning;

        public MainFormController(TabControl tabControl)
        {
            this.tabControl = tabControl;
        }

        public void startLoadingProcess()
        {
            Thread thread = new Thread(new ThreadStart(runProgressBar));
            thread.Start();

            ChampionFetcher cf = new ChampionFetcher(cpd);
            Thread threadFetchData = new Thread(new ThreadStart(cf.fetchData));

            cf.fetchData();
            chdata = cf.getModel();

            progressForm.Invoke((MethodInvoker)delegate() {
                progressForm.Close(); 
            });

            createTabPages();

        }

        public void validateProfile()
        {
            CareerProfileFetcher cpf = new CareerProfileFetcher();
            if (cpf.fetchData())
            {
                cpd = cpf.getModel();
                startLoadingProcess();
            }
            else
            {
                MessageBox.Show(
                    "Character couldn't be found. Please check your entered data again.",
                    "Character not found.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1
                );
            }

        }

        private void runProgressBar()
        {
            progressForm = new ProgressBarDisplay();
            progressForm.ShowDialog();
        }

        private void createTabPages()
        {
            EquipmentTabPageCreator etpc = new EquipmentTabPageCreator(tabControl, chdata);
            etpc.startCreating();
        }
    }
}
