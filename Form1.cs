using Renci.SshNet;
using System.Diagnostics;
using System.Text;

namespace SSHRandD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSSH_Click(object sender, EventArgs e)
        {
            RunCommand();
        }
        private void RunCommand()
        {
            var host = "192.168.240.11";
            var username = "";
            var password = "";

            byte[] expectedFingerPrint = new byte[] {
                                            0x66, 0x31, 0xaf, 0x00, 0x54, 0xb9, 0x87, 0x31,
                                            0xff, 0x58, 0x1c, 0x31, 0xb1, 0xa2, 0x4c, 0x6b
                                        };

            using (var client = new SshClient(host, username, password))
            {
                client.HostKeyReceived += (sender, e) =>
                {
                    if (expectedFingerPrint.Length == e.FingerPrint.Length)
                    {
                        //for (var i = 0; i < expectedFingerPrint.Length; i++)
                        //{
                        //    if (expectedFingerPrint[i] != e.FingerPrint[i])
                        //    {
                        //        e.CanTrust = false;
                        //        break;
                        //    }
                        //}
                        e.CanTrust = true;
                    }
                    else
                    {
                        e.CanTrust = false;
                    }
                };
                client.Connect();
               // var sshcommand= client.CreateCommand("sudo usermod -aG sudo sajidur");
               // var result=sshcommand.Execute();
                var res=client.RunCommand("sudo -S <<< Asa@12345 docker ps");
                var run = client.RunCommand("sudo -S <<< Asa@12345  docker kill c86af32565d1");
            }
        }
    }
}