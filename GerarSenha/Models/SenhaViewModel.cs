using System.Collections.Generic;

namespace GerarSenha.Models
{
    public class SenhaViewModel
    {
        public int Id { get; set; }
        public int Caracteres { get; set; }
        public List<CheckBoxItem> ListaCheckBoxes { get; set; }
        public List<string> ListaString { get; set; }
    }
}
