﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;

namespace TcpCommunication
{
    [Serializable()]
    [DataContract]
    public class Osoba : RejestrOsob
    {


        [DataMember]
        public string Imie { get; set; }
        [DataMember]
        public string Nazwisko { get; set; }
        [DataMember]
        public string Wiek { get; set; }
        [DataMember]
        public string Plec { get; set; }
        [DataMember]
        public string KodPocztowy { get; set; }
        [DataMember]
        public string Miasto { get; set; }
        [DataMember]
        public string Ulica { get; set; }
        [DataMember]
        public string NrDomu { get; set; }
        [DataMember]
        public string NrMieszkania { get; set; }
        [DataMember]
        public string OsobaID { get; set; }

        public Osoba() { }

        public Osoba(
            string imie = "",
            string nazwisko = "",
            string plec = "",
            string miasto = "",
            string ulica = "",
            string wiek = "",
            string kodpocztowy = "",
            string nrdomu = "",
            string nrmieszkania = "",
            string osobaid = "")
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Plec = plec;
            Miasto = miasto;
            Ulica = ulica;
            Wiek = wiek;
            KodPocztowy = kodpocztowy;
            NrDomu = nrdomu;
            NrMieszkania = nrmieszkania;
            OsobaID = osobaid;
        }

        public override string ToString()
        {
            return string.Format(
                "Imię: {0} \n" +
                "Nazwisko: {1} \n" +
                "Płeć: {2} \n" +
                "Miasto: {3} \n" +
                "Ulica: {4} \n" +
                "Wiek: {5} \n" +
                "Kod pocztowy: {6} \n" +
                "Numer domu: {7} \n" +
                "Numer mieszkania: {8} \n" +
                "ID osoby: {9}",
                Imie, Nazwisko, Plec, Miasto, Ulica, Wiek, KodPocztowy, NrDomu, NrMieszkania, OsobaID);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {

            info.AddValue("Imię", Imie);
            info.AddValue("Nazwisko", Nazwisko);
            info.AddValue("Płeć", Plec);
            info.AddValue("Miasto", Miasto);
            info.AddValue("Ulica", Ulica);
            info.AddValue("Wiek", Wiek);
            info.AddValue("Kod pocztowy", KodPocztowy);
            info.AddValue("Numer domu", NrDomu);
            info.AddValue("Numer mieszkania", NrMieszkania);
            info.AddValue("ID osoby", OsobaID);
        }

        public Osoba(SerializationInfo info, StreamingContext ctxt)
        {

            Imie = (string)info.GetValue("Imie", typeof(string));
            Nazwisko = (string)info.GetValue("Nazwisko", typeof(string));
            Plec = (string)info.GetValue("Plec", typeof(string));
            Miasto = (string)info.GetValue("Miasto", typeof(string));
            Ulica = (string)info.GetValue("Ulica", typeof(string));
            Wiek = (string)info.GetValue("Wiek", typeof(string));
            KodPocztowy = (string)info.GetValue("Kod pocztowy", typeof(string));
            NrDomu = (string)info.GetValue("Numer domu", typeof(string));
            NrMieszkania = (string)info.GetValue("Numer mieszkania", typeof(string));
            OsobaID = (string)info.GetValue("ID osoby", typeof(string));

        }


    }
}
