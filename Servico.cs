using MailService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailService
{
    public partial class Servico : ServiceBase
    {
        public Servico()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ThreadStart start = new ThreadStart(criarEmail);
            Thread thread = new Thread(start);

            thread.Start();
        }

        protected override void OnStop()
        {
        }
       void criarEmail()
        {
            while (true)
            {
                Thread.Sleep(5000);
                Mail m = new Mail
                {

                    MailDestino = "contato.asalltech@gmail.com",
                    MailOrigem = "cliente.asalltech@gmail.com",
                    NomeDestino = "Allyson",
                    NomeOrigen = "Cliente",
                    Assunto = "Teste",
                    Mensagem = "ola Asalltech"


                };

                m.SendMail(m);

            }
          
        }
        

        
    }
}
