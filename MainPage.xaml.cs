using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x410

namespace Calcolatrice
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
		// Cose da fare sul design (per allenarsi con XAML)
		// TODO: Gestire l'allargamento della finestra
		// TODO: Rendere acrilica la barra del titolo (C#)
		// TODO: Posizionare il blocco di testo nella posizione corretta (è stato commentato)
		// TODO: Aggiungere reveal ai pulsanti
		// TODO: Variare stile e dimensione font, colore di sfondo, margine e disposizione dei pulsanti in modo da renderla simile alla calcolatrice di Windows
		
		// Cose da fare sul funzionamento
		// TODO: Agganciare l'evento Button_Click ai pulsanti
		// TODO: Discriminare il pulsante che ha generato l'evento ed aggiungere il testo in esso contenuto al display
		// TODO: Tokenizzare ed interpretare il contenuto del display alla pressione del tasto =
		// TODO: Calcolo e display del risultato
		// TODO: Inserimento di valori dalla tastiera

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
