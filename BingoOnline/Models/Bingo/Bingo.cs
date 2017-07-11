﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static BingoOnline.Utility.StatusEnum;

namespace BingoOnline.Models
{
    /// <summary>
    /// Tabela do Evento Bingo
    /// </summary>
    [Table("Bingo")]
    public class Bingo
    {

        public int BingoId { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [DisplayName("Status")]
        public Status Status { get; set; }
        [DisplayName("Motivo Cancelamento")]
        public string MotivoCancelamento { get; set; }
        [DisplayName("Data Cancelamento")]
        public DateTime? DataCancelamento { get; set; }
        [DisplayName("Data Criação")]
        public DateTime DataCriacao { get; set; }
        [DisplayName("Data Realização")]
        public DateTime DataRealizacao { get; set; }
        public virtual ICollection<OrdemSorteio> OrdemSorteio { get; set; }
        public virtual ICollection<Cartela> Cartela { get; set; }

    }

}