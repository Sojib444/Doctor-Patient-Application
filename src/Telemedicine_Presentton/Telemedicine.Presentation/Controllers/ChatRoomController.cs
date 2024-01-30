//using Microsoft.AspNetCore.Mvc;
//using System.Security.Claims;
//using Telemedicine.Application.Services.ChatRooms;
//using Telemedicine.Domain.Users;

//namespace Telemedicine.Presentation.Controllers
//{
//    public class ChatRoomController : Controller
//    {
//        private readonly IChatRoomService chatRoomService;

//        public ChatRoomController(IChatRoomService chatRoomService)
//        {
//            this.chatRoomService = chatRoomService;
//        }

//        // GET: api/ChatRooms
//        [HttpGet]
//        [Route("/[controller]/GetChatRoom")]
//        public async Task<ActionResult> GetChatRoom()
//        {
//            var rooms = await chatRoomService.GetChatRooms();

//            if (rooms == null)
//            {
//                return NotFound();
//            }

//            return Ok(rooms);
//        }

//        // POST: api/ChatRooms
//        [HttpPost]
//        [Route("/[controller]/PostChatRoom")]
//        public async Task<ActionResult> PostChatRoom(ChatRoom chatRoom)
//        {
//            await chatRoomService.AddChatRoom(chatRoom);

//            return CreatedAtAction("GetChatRoom", new { id = chatRoom.Id }, chatRoom);
//        }

//        // DELETE: api/ChatRooms/5
//        [HttpDelete("{id}")]
//        [Route("/[controller]/DeleteChatRoom/{id}")]
//        public async Task<IActionResult> DeleteChatRoom(Guid id)
//        {
//            var chatRoom = await chatRoomService.GetChatRoom(id);

//            if (chatRoom == null)
//            {
//                return NotFound();
//            }

//            await chatRoomService.DeleteChatRoom(id);

//            return Ok();
//        }

//        [HttpGet]
//        [Route("/[controller]/GetChatUser")]
//        public async Task<ActionResult<Object>> GetChatUser()
//        {
//            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
//            var users = await chatRoomService.GetChatUsers();

//            if (users == null)
//            {
//                return NotFound();
//            }

//            return users.Where(u => u.Id != userId).Select(u => new { u.Id, u.UserName }).ToList();
//        }
//    }
//}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Telemedicine.Application.Services.ChatRooms;
using Telemedicine.Domain.UnitofWork;
using Telemedicine.Domain.Users;
using Telemedicine.EntityFramework.Core;

namespace SignalRSample.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ChatRoomController : ControllerBase
    {
        private readonly IApplicationDbContex _context;
        private readonly IChatRoomService _chatRoomService;

        public IApplicationUnitofWork UnitofWork { get; }

        public ChatRoomController(IApplicationDbContex context, IChatRoomService chatRoomService,IApplicationUnitofWork unitofWork)
        {
            _context = context;
            _chatRoomService = chatRoomService;
            UnitofWork = unitofWork;
        }

        // GET: api/ChatRooms
        [HttpGet]
        [Route("/[controller]/GetChatRoom")]
        public async Task<ActionResult<IEnumerable<ChatRoom>>> GetChatRoom()
        {
            if (_context.ChatRooms == null)
            {
                return NotFound();
            }
            return await _context.ChatRooms.ToListAsync();
        }

        [HttpGet]
        [Route("/[controller]/GetChatUser")]
        public async Task<ActionResult<Object>> GetChatUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var users = await _context.Doctors.ToListAsync();

            if (users == null)
            {
                return NotFound();
            }

            return users.Where(u => u.Id != userId).Select(u => new { u.Id, u.UserName }).ToList();
        }




        // POST: api/ChatRooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("/[controller]/PostChatRoom")]
        public async Task<ActionResult<ChatRoom>> PostChatRoom(ChatRoom chatRoom)
        {
            if (_context.ChatRooms == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ChatRoom'  is null.");
            }

            await _chatRoomService.AddChatRoom(chatRoom);

            return CreatedAtAction("GetChatRoom", new { id = chatRoom.Id }, chatRoom);
        }

        // DELETE: api/ChatRooms/5
        [HttpDelete("{id}")]
        [Route("/[controller]/DeleteChatRoom/{id}")]
        public async Task<IActionResult> DeleteChatRoom(int id)
        {
            if (_context.ChatRooms == null)
            {
                return NotFound();
            }
            var chatRoom = await _context.ChatRooms.FindAsync(id);
            if (chatRoom == null)
            {
                return NotFound();
            }

            _context.ChatRooms.Remove(chatRoom);
            await UnitofWork.SaveChangeAsync();

            var room = await _context.ChatRooms.FirstOrDefaultAsync();

            return Ok(new { deleted = id, selected = (room == null ? 0 : room.Id) });
        }


    }
}

