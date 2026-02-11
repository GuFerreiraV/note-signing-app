using Microsoft.EntityFrameworkCore;
using note_signing_app.Data;
using note_signing_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#if WINDOWS
using WinRT.note_signing_appVtableClasses;
#endif

namespace note_signing_app.Services
{
    public class NoteServices
    {
        private readonly AppDbContext _dbContext;

        public NoteServices(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ConsultationNoteDTO?> SearchNoteAsync(string filial, string serie, string nota)
        {
            var sf2 = await _dbContext.Sf2010s
                .Where(f => EF.Functions.Like(f.F2Filial, $"%{filial}%")
                        && EF.Functions.Like(f.F2Serie, $"%{serie}%")
                        && EF.Functions.Like(f.F2Doc, $"%{nota}%")
                        && (f.DELET == null || f.DELET != "*")
                        ).FirstOrDefaultAsync();

            if (sf2 == null) return null;

            var sa1 = await _dbContext.Sa1010s
                .Where(a => a.A1Cod.Trim() == sf2.F2Cliente.Trim() &&
                        a.A1Loja.Trim() == sf2.F2Loja.Trim() &&
                        a.DELET != "*")
                .FirstOrDefaultAsync();
                     

            return new ConsultationNoteDTO(
                    sf2.F2Filial,
                    sf2.F2Serie,
                    sf2.F2Doc,
                    sf2.F2Cliente,
                    sf2.F2Loja,
                    sa1?.A1Nome.Trim() ?? "Cliente não encontrado",
                    sf2.F2Emissao
                );

        }

        public async Task<bool> SaveSignatureAsync(Zxo010 record)
        {
            try
            {
                // Busca o próximo RECNO se não for automático no banco (comum em Protheus/Oracle)
                // Se o seu banco tiver Trigger/Sequence para o R_E_C_N_O_, pode remover as 2 linhas abaixo
                var lastRec = await _dbContext.Zxo010s.MaxAsync(x => (decimal?)x.RECNO) ?? 0;
                record.RECNO = lastRec + 1;

                _dbContext.Zxo010s.Add(record);
                return await _dbContext.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}