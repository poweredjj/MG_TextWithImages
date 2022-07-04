using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace TextWithImages_demo
{
    public class TextWithImagesDemo : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private SpriteFont fontFreeSansBold;
        private Texture2D imageEnter;
        private Texture2D imageUp;
        private Texture2D imageSpace;
        private TextWithImages textWithImages;

        public TextWithImagesDemo()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            fontFreeSansBold = Content.Load<SpriteFont>("fonts/FreeSansBold");

            imageEnter = Content.Load<Texture2D>("images/enter");
            imageSpace = Content.Load<Texture2D>("images/space");
            imageUp = Content.Load<Texture2D>("images/up");

            textWithImages = new TextWithImages(spriteBatch: _spriteBatch, font: fontFreeSansBold, text: "This is a sample text with images.\nYou can use this marker | to put an image anywhere you like.\nImages can have various proportions | | |.\nShadows and animation are optional.\n\nGraphics by TRBRY from opengameart.org.\nFreesans font used.\nYou can use TextWithImages freely (commercial uses included).", imageList: new List<Texture2D> { imageUp, imageEnter, imageSpace, imageUp }, animate: true, framesPerChar: 2, charsPerFrame: 1);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            textWithImages.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            Vector2 textPos = new Vector2((_graphics.PreferredBackBufferWidth - textWithImages.textWidth) / 2, (_graphics.PreferredBackBufferHeight - textWithImages.textHeight) / 2);
            textWithImages.Draw(position: textPos, color: Color.White, shadowColor: Color.DarkBlue * 0.4f, shadowOffset: new Vector2(2, 2));

            _spriteBatch.End();
        }
    }
}
