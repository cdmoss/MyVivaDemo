using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnrealServer.Data;

[Route("pins")]
public class PinDropsController : ControllerBase {
    private readonly UnrealContext _ctx;

    public PinDropsController(UnrealContext ctx)
    {
        _ctx = ctx;
    }

    [Route("add")]
    [HttpPost]
    public async Task<IActionResult> PostPin() {
        var newPin = new PinDrop {
            TimeStamp = System.DateTime.Now
        };

        _ctx.Add(newPin);
        await _ctx.SaveChangesAsync();

        return new OkResult();
    }
}