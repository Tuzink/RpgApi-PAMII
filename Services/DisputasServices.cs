using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
using RpgApi.Dto;

namespace RpgApi.Services
{
    public class DisputasServices
    {
        private readonly DataContext _context;
        public DisputasServices(DataContext context)
        {
            _context = context;
        }

        public async  Task<List<DisputaDto>> ObterDisputas()
        {
            var resultado = _context.Database.SqlQueryRaw<DisputaDto>(@"SELECT 
D.Id, at.Nome as [Atacante], op.Nome as Oponente,
d.Tx_Narracao Narracao, us.Username NomeUsuarioAtacante,
usOp.Username NomeUsuarioOponente

FROM TB_DISPUTAS D

INNER JOIN TB_PERSONAGENS at on D.AtacanteId = at.Id
INNER JOIN TB_PERSONAGENS op on D.OponenteId = op.Id
INNER JOIN TB_USUARIOS usOP on op.UsuarioId = usOp.Id
INNER JOIN TB_USUARIOS us on at.UsuarioId = usOp.Id");
            return await resultado.ToListAsync();
        }
    }
}