﻿using Microsoft.AspNetCore.Mvc;
using Pustok.Business.DTOs.AuthorDtos;
using Pustok.Business.DTOs.CommonDtos;
using Pustok.Business.Exceptions.AuthorExceptions;
using Pustok.Business.Services.Interfaces;
using System.Net;

namespace Pustok.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorsController : ControllerBase
{
    private readonly IAuthorService _authorService;

    public AuthorsController(IAuthorService authorService)
    {
        _authorService = authorService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] string? search)
    {
        var authors = await _authorService.GetAllAuthorsAsync(search);
        return Ok(authors);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var author = await _authorService.GetAuthorByIdAsync(id);
        return Ok(author);
    }

    [HttpPost]
    public async Task<IActionResult> Create(AuthorPostDto authorPostDto)
    {
        await _authorService.CreateAuthorAsync(authorPostDto);
        return StatusCode((int)HttpStatusCode.Created, new ResponseDto(HttpStatusCode.Created, "Author successfully created"));
    }
}