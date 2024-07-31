﻿using Fina.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions;

public class CreateTransactionRequest : Request
{
    [Required(ErrorMessage = "Título inválido")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Tipo inválido")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

    [Required(ErrorMessage = "Título inválido")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Valor inválido")]
    public long CategoryId { get; set; }

    [Required(ErrorMessage = "Data inválida")]
    public DateTime? PaidOrReceivedAt { get; set; }
}
