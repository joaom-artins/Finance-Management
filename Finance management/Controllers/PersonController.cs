using Finance_management.Context;
using Microsoft.AspNetCore.Mvc;

namespace Finance_management.Controllers;
[ApiController]
[Route("api/[controller]")]
public class PersonController:ControllerBase
{
    private readonly AppDBContext _Context;

    public PersonController(AppDBContext context)
    {
       _Context = context;
    }
}
