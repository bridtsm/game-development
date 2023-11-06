
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project1.interfaces;

namespace Project1
{
    internal class Hero : IGameObject
    {
        Texture2D texture;
        Animation animation;

        public Hero(Texture2D texture)
        {
            this.texture = texture;
            animation = new Animation();
            animation.GetFramesFromTextureProperties(texture.Width, texture.Height, 5, 2);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Vector2(0, 0), animation.CurrentFrame.SourceRectangle, Color.White);
        }

        public void Update(GameTime gameTime)
        {
            animation.Update(gameTime);
        }
    }
}
