using LANCHESMVC.Models;
using LANCHESMVC.Repositories.Interfaces;
using LANCHESMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace LANCHESMVC.Controllers;

public class LancheController : Controller
{
    private readonly ILancheRepository _lancheRepository;

    public LancheController(ILancheRepository lancheRepository)
    {
        _lancheRepository = lancheRepository;
    }

    public IActionResult List(string categoria)
    {
        IEnumerable<Lanche> lanches;
        string categoriaAtual = string.Empty;

        if (string.IsNullOrEmpty(categoria))
        {
            lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
            categoriaAtual = "Todos os lanches";
        }
        else
        {
            lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals(categoria)).
                OrderBy(l => l.Nome);

            categoriaAtual = categoria;
        }

        var lanchesListViewModel = new LancheListViewModel
        {
            Lanches = lanches,
            CategoriaAtual = categoriaAtual
        };

        return View(lanchesListViewModel);
    }

    public IActionResult Details(int lancheId)
    {
        var lanches = _lancheRepository.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        return View(lanches);
    }

    public IActionResult Search(string searchString)
    {
        IEnumerable<Lanche> lanches;
        string categoriaAtual = string.Empty;

        if (string.IsNullOrEmpty(searchString))
        {
            lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
            categoriaAtual = "Todos os Lanches";
        }
        else
        {
            lanches = _lancheRepository.Lanches.Where(p => p.Nome.ToLower().Contains(searchString.ToLower()));

            if (lanches.Any())

                categoriaAtual = "Lanches";
            else

                categoriaAtual = "Nenhum Lanche foi encontrado";
        }

        return View("~/Views/Lanche/List.cshtml", new LancheListViewModel 
        { 
            Lanches = lanches,
            CategoriaAtual = categoriaAtual

        });
    }
}