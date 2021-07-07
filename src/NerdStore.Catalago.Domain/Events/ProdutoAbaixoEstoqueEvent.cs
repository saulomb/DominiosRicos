﻿using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalago.Domain.Events
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
