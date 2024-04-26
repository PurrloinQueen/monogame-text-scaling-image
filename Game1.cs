using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Runtime.Remoting;

namespace monogame_2_scaling_and_text
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;
        
        Texture2D rectangleTexture, circleTexture;
        Rectangle creatureFace, creatureEye1, creatureEye2, creatureSmile, creatureHand1, creatureHand2;
        Random generator = new Random();
        SpriteFont MessageFont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            window = new Rectangle(0, 0, 800, 500);
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.ApplyChanges();

            creatureFace = new Rectangle(window.Center.X - 150, 75, 300, 350);
            creatureEye1 = new Rectangle(200, 200, 100, 110);
            creatureEye2 = new Rectangle(500, 200, 100, 110);
            creatureSmile = new Rectangle(window.Center.X - 150, 250, 350, 20);
            creatureHand1 = new Rectangle(200, 300, 200, 10);
            creatureHand2 = new Rectangle(400, 300, 200, 10);

            this.Window.Title = "abomination";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");
            MessageFont = Content.Load<SpriteFont>("MessageFont");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkGray);
            

            _spriteBatch.Begin();

            _spriteBatch.Draw(rectangleTexture, creatureHand1, Color.HotPink);
            _spriteBatch.Draw(rectangleTexture, creatureHand2, Color.HotPink);
            _spriteBatch.Draw(circleTexture, creatureFace, Color.HotPink);
            _spriteBatch.Draw(circleTexture, creatureEye1, Color.Black);
            _spriteBatch.Draw(circleTexture, creatureEye2, Color.Black);
            _spriteBatch.Draw(rectangleTexture, creatureSmile, Color.Black);
            _spriteBatch.DrawString(MessageFont, "kirby.", new Vector2(10, 350), Color.DarkGreen);

            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}