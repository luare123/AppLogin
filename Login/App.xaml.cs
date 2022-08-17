﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
{
    public partial class App : Application
    {
        public List<DadosUsuario> list_usuarios = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Email = "aluno@etec",
                Nome = "Aluno",
                Senha = "123"
            },
            new DadosUsuario()
            {
                Email = "prof@etec",
                Nome = "Professor",
                Senha = "456"
            }
        };

        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new Protegida();
            else
                MainPage = new Login();
        }
        protected override void OnStart()
        {
        }
        protected override void OnSleep()
        {
        }
        protected override void OnResume()
        {
        }

    }
}
