using System;
using Acme.BookStore.Domain.Shared.Enums;
using Volo.Abp.Application.Dtos;
namespace Acme.BookStore.Application.Contracts.Books
{
    public class BookDto : AuditedEntityDto<Guid> 
    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}