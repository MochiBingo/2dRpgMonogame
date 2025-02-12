using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace _2dRpgMonogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private int sizeX = 15;
        private int sizeY = 10;
        private bool canWalk;
        private bool isExit;
        public Random rand = new Random();

        private Texture2D ground;
        private Texture2D tree;
        private Texture2D playerSprite;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected void GenerateMap()
        {

        }
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            ground = this.Content.Load<Texture2D>("tile_0000");
            tree = this.Content.Load<Texture2D>("tile_0005");
            playerSprite = this.Content.Load<Texture2D>("tile_0094");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            float deltaTime = gameTime.ElapsedGameTime.Milliseconds * 0.01f;

            player.Update(deltaTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
    public class player
    {
        public player(Game1 game, Vector2 initialposition)
        {

        }
        public void Update(float deltaTime)
        {
            KeyboardState kstate = Keyboard.GetState();
        }
    }
}
