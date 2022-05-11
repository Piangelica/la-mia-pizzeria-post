namespace LaPrimaWEBAPP.Models
{
    public class Pizze
    {
       
        public string Nome { get; set; }
        [Required(ErrorMessage="Il campo descrizione è obbligatorio")]
        public string Descrizione { get; set; }
        public string Immagine { get; set; }
        public double Prezzo { get; set; }

        public Pizze()
        {
     
        }
    public Pizze( string Nome, string Descrizione, string Immagine, double Prezzo)
        {
            
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Immagine = immagine;
            this.Prezzo = prezzo; 


        }
    }
}
