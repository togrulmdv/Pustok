﻿using AutoMapper;
using Pustok.Business.DTOs.AuthorDtos;
using Pustok.Business.DTOs.BookDtos;
using Pustok.Core.Entities;

namespace Pustok.Business.MappingProfiles;

public class BookMapper : Profile
{
    public BookMapper()
    {
        CreateMap<BookPostDto, Book>()
            .ForMember(b => b.BookAuthors, x => x.MapFrom(dto => dto.AuthorIds.Select(id => new BookAuthor { AuthorId = id }))).ReverseMap();
        CreateMap<Book, BookGetDto>()
            .ForCtorParam("Authors", x => x.MapFrom(b => b.BookAuthors.Select(ba => new AuthorGetDto(ba.Author.Id, ba.Author.Fullname))));
    }
}