using NUnit.Framework;
using Aqueous.Domain;
using Aqueous.Presentation;

namespace UnitTests
{
    public class AqueousTests
    {
        GameState state;

        [SetUp]
        public void Setup()
        {
            state = new GameState();
        }

        [Test]
        public void ValidDirectionParsing()
        {
            Assert.AreEqual(Direction.North, DirectionHelper.DirectionFromString("north"));
            Assert.AreEqual(Direction.South, DirectionHelper.DirectionFromString("south"));
            Assert.AreEqual(Direction.West, DirectionHelper.DirectionFromString("west"));
            Assert.Pass();
        }

        [Test]
        public void MoveBetweenRooms()
        {
            Room room = state.CurrentRoom;
            Room nextRoom = state.roomManager.GetRoom(typeof(Reactor));
            state.MoveToRoom(nextRoom);
            Room currentRoom = state.CurrentRoom;
            Assert.AreEqual(nextRoom, currentRoom);
            Assert.Pass();
        }

        [Test]
        public void AddItemToInventory()
        {
            Assert.AreEqual(0, state.itemManager.Items.Count);
            state.itemManager.AddItem(new SecurityKey());
            Assert.AreEqual(1, state.itemManager.Items.Count);
            Assert.Pass();
        }

        [Test]
        public void MoveUsingCommands()
        {
            Room startRoom = state.roomManager.GetRoom(typeof(Reactor));
            state.MoveToRoom(startRoom);
            Command moveCommand = new MoveCommand();
            bool result = moveCommand.TryExecute("north", state);
            Assert.AreEqual(result, true);
            Room room = state.CurrentRoom;

            Room expectedRoom = state.roomManager.GetRoom(typeof(UpperEngine));
            Assert.AreEqual(room, expectedRoom);
            Assert.Pass();
        }
    }
}

