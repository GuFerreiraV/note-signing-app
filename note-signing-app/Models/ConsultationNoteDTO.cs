using System;
using System.Collections.Generic;
using System.Text;

namespace note_signing_app.Models
{
    public record ConsultationNoteDTO (
        string Filial,
        string Serie,
        string NoteNumber,
        string ClientCode,
        string ClientStore,
        string ClientName,
        string DateIssue
    );
}