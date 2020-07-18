using FormFileJson.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormFileJson.Models
{
    [ModelBinder(typeof(FormFileWithJsonModelBinder), Name = "candidato")]
    public class CandidatoViewModel
    {        
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        
        public IFormFile ImagemUpload { get; set; }
    }
}
