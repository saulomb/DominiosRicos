﻿using NerdStore.Core.Messages.CommonMessages.DomainEvents;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalogo.Domain.Events
{
    public class ProdutoAbaixoEstoqueEvent : DomainEvent
    {
        public int QuantidadeRestante { get; private set; }
        
        public ProdutoAbaixoEstoqueEvent(Guid aggregateid, int quantidadeRestante) : base(aggregateid)
        {
            QuantidadeRestante = quantidadeRestante;
        }
    }
}
