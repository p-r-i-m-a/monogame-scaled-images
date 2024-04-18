using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Globalization;

namespace monogame_scaled_images
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D rectangle, circle;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 640;
            _graphics.PreferredBackBufferHeight = 640;
            _graphics.ApplyChanges();


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            rectangle = Content.Load<Texture2D>("rectangle");
            circle = Content.Load<Texture2D>("circle");

            // TODO: use this.Content to load your game content here
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
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            int rectSize = 80; // Size of each rectangle
            int rows = 8; // Number of rows
            int cols = 8; // Number of columns

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int xPos = j * rectSize; // Calculate x position based on column
                    int yPos = i * rectSize; // Calculate y position based on row

                    Rectangle rect = new Rectangle(xPos, yPos, rectSize, rectSize);
                    if (j%2 == 0 && i%2 == 0)
                    {
                        _spriteBatch.Draw(rectangle, rect, Color.Black);
                    }
                    else if (j%2 == 1 && i%2 == 1)
                    {
                        _spriteBatch.Draw(rectangle, rect, Color.Black);
                    }
                    else
                    {
                        _spriteBatch.Draw(rectangle, rect, Color.White);

                    }


                }
            }

            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}