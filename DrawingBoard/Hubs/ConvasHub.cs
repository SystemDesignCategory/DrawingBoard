using Microsoft.AspNetCore.SignalR;

namespace DrawingBoard.Hubs
{
    public class CanvasHub : Hub
    {
        // Method that will be called by the client to broadcast drawing coordinates
        public async Task DrawOnCanvas(int x1, int y1, int x2, int y2)
        {
            // Broadcast the coordinates to all connected clients
            await Clients.Others.SendAsync("ReceiveDraw", x1, y1, x2, y2);
        }
        public async Task ClearCanvas()
        {
            await Clients.Others.SendAsync("ClearCanvas");
        }
    }
}
