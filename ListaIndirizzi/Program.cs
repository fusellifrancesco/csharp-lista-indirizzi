using ListaIndirizzi;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;



List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

StreamReader file = File.OpenText("C:\\Users\\User\\Desktop\\Esercizi Generation\\ListaIndirizzi\\ListaIndirizzi\\File\\addresses.csv");

file.ReadLine();


while (!file.EndOfStream) {

    string riga = file.ReadLine();

    string[] informazioniIndirizzo = riga.Split(",");

    if (informazioniIndirizzo.Length > 6) {
        string nome = informazioniIndirizzo[0] + "-" + informazioniIndirizzo[1];
        string cognome = informazioniIndirizzo[2];
        string via = informazioniIndirizzo[3];
        string citta = informazioniIndirizzo[4];
        string provincia = informazioniIndirizzo[5];
        string zip = informazioniIndirizzo[6];

        Indirizzo indirizzo = new Indirizzo(nome, cognome, via, citta, provincia, zip);
        listaIndirizzi.Add(indirizzo);
    } else if (informazioniIndirizzo.Length < 6) {
        string nome = informazioniIndirizzo[0];
        string citta = informazioniIndirizzo[1];
        string provincia = informazioniIndirizzo[2];
        string zip = informazioniIndirizzo[3];

        Indirizzo indirizzo = new Indirizzo(nome, citta, provincia, zip);
        listaIndirizzi.Add(indirizzo);
    } else {
        string nome = informazioniIndirizzo[0];
        string cognome = informazioniIndirizzo[1];
        string via = informazioniIndirizzo[2];
        string citta = informazioniIndirizzo[3];
        string provincia = informazioniIndirizzo[4];
        string zip = informazioniIndirizzo[5];

        Indirizzo indirizzo = new Indirizzo(nome, cognome, via, citta, provincia, zip);
        listaIndirizzi.Add(indirizzo);
    }

}

file.Close();

foreach (Indirizzo indirizzo in listaIndirizzi) {
    Console.WriteLine(indirizzo.ToString());
}



