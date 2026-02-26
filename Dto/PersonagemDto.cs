using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgApi.Dto
{
    public class PersonagemDto
    {
        public int id {get; set;}
        public string Nome {get; set;} = string.Empty;
        public int Qthabilidades {get; set;}
        public int QtDisputas {get; set;}
        public int PontosVida {get; set;}
        public int Forca {get; set;}
        public int Defesa {get; set;}
        public int Inteligencia {get; set;}
        public int Vitorias {get; set;}
        public int Derrotas {get; set;}
        public string ArmaNome {get; set;}
        public string UsuarioNome { get; set;} = string.Empty;
        public string Perfil { get; set;} = string.Empty;
        public string Email { get; set;} = string.Empty;
        public string HabilidadeNome { get; set;} = string.Empty;
        public int habilidadeDano { get; set;} 


    }
}