using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Cpnucleo.Infra.CrossCutting.Util.ViewModels
{
    [DataContract]
    public class RecursoTarefaViewModel : BaseViewModel
    {
        [Display(Name = "Recurso")]
        [Required(ErrorMessage = "Necessário informar o {0}.")]
        [DataMember(Order = 3)]
        public Guid IdRecurso { get; set; }

        [Display(Name = "Tarefa")]
        [Required(ErrorMessage = "Necessário informar o {0}.")]
        [DataMember(Order = 4)]
        public Guid IdTarefa { get; set; }

        [DataMember(Order = 5)]
        public RecursoViewModel Recurso { get; set; }

        [DataMember(Order = 6)]
        public TarefaViewModel Tarefa { get; set; }
    }
}