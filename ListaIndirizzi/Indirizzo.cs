using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi {
    public class Indirizzo {

        private string nome;
        private string cognome;
        private string via;
        private string citta;
        private string provincia;
        private string zip;

        public Indirizzo(string nome, string cognome, string via, string citta, string provincia, string zip) {
            this.nome = nome;
            this.cognome = cognome;
            this.via = via;
            this.citta = citta;
            this.provincia = provincia;
            this.zip = zip;
        }

        public Indirizzo(string nome, string citta, string provincia, string zip) {
            this.nome = nome;
            this.citta = citta;
            this.provincia = provincia;
            this.zip = zip;
        }



        public string GetNome() {
            return nome;
        }

        public string GetCognome() {
            return cognome;
        }

        public string GetVia() {
            return via;
        }

        public string GetCitta() {
            return citta;
        }

        public string GetProvincia() {
            return provincia;
        }

        public string GetZip() {
            return zip;
        }

        public override string ToString() {
            return (@$"
                    --------------------------
                    Nome: {nome}
                    Cognome: {cognome}
                    Via: {via}
                    Città: {citta}
                    Provincia: {provincia}
                    ZIP: {zip}
                    --------------------------

                    ");

        }
    }
}
