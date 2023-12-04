using System;
using System.Runtime.Serialization;

namespace ConsultaMatricula.Records
{
    [DataContract]
    public class Aluno
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string TxNome { get; set; }

        [DataMember]
        public DateTime DtNascimento { get; set; }

        [DataMember]
        public string TxGenero { get; set; }

        [DataMember]
        public string TxMatricula { get; set; }

        [DataMember]
        public string TxCurso { get; set; }

        [DataMember]
        public DateTime DtMatricula { get; set; }

        [DataMember]
        public string TxStatusMatricula { get; set; }

        [DataMember]
        public string TxCep { get; set; }

        [DataMember]
        public string TxUF { get; set; }

        [DataMember]
        public string TxCidade { get; set; }

        [DataMember]
        public string TxRua { get; set; }

        [DataMember]
        public string TxNro { get; set; }

        [DataMember]
        public string TxFone1 { get; set; }

        [DataMember]
        public string TxFone2 { get; set; }

        [DataMember]
        public string TxEmail { get; set; }

        [DataMember]
        public string TxNomeMae { get; set; }

        [DataMember]
        public string TxNomePai { get; set; }

    }
}