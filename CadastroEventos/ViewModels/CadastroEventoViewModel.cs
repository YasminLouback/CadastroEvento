using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using CadastroEventos.Models;

namespace CadastroEventos.ViewModels
{
    public class CadastroEventoViewModel : INotifyPropertyChanged
    {
        public Evento Evento { get; set; }
        public ICommand CadastrarCommand { get; }

        public CadastroEventoViewModel()
        {
            Evento = new Evento
            {
                DataInicio = DateTime.Today,
                DataFim = DateTime.Today.AddDays(1)
            };

            CadastrarCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(
                    new ResumoEventoPage(Evento)
                );
            });
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string? nome = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nome));
    }
}
