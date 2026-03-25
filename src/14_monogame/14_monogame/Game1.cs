using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _14_monogame;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    //proměnná rectangle
    private Texture2D _rectangle;
    //pokud chci jednoduchy pohyb pouziju tohle
    private int _posY;
    private int _posX;
    //pokud chci konstantní rychlost i diagonalne pouziju tohle
    private Vector2 _position = new Vector2(50, 50);
    private float _speed = 300;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        
        _rectangle = new Texture2D(GraphicsDevice, 1, 1);
        //nastaveni barvy ctverce
        _rectangle.SetData(new[] { Color.White });
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        KeyboardState _ks = Keyboard.GetState();
        Vector2 _movement = Vector2.Zero;
        //tohle je logika jednoducheho pohybu
        if (Keyboard.GetState().IsKeyDown(Keys.Up)) _posY--;
        if (Keyboard.GetState().IsKeyDown(Keys.Down)) _posY++;
        if (Keyboard.GetState().IsKeyDown(Keys.Left)) _posX--;
        if (Keyboard.GetState().IsKeyDown(Keys.Right)) _posX++;
        
        // tohle je logika pohybu s konstantni rychlosti ve vsech smerech
        /*if (_ks.IsKeyDown(Keys.Right)) _movement.X += 1;
        if (_ks.IsKeyDown(Keys.Left)) _movement.X -= 1;
        if (_ks.IsKeyDown(Keys.Down)) _movement.Y += 1;
        if (_ks.IsKeyDown(Keys.Up)) _movement.Y -= 1;
        if (_movement != Vector2.Zero)*/
            _movement.Normalize();
        
        float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
        _position += _movement * _speed * deltaTime;
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();
        //vyskresleni ctverce s jednoduchou logikou pohybu
        _spriteBatch.Draw(_rectangle, new Rectangle(_posX, _posY, 50, 50), Color.White);
        
        //vykresleni ctverce s pokrocilou logikou pohybu
        //_spriteBatch.Draw(_rectangle, new Rectangle((int)_position.X, (int)_position.Y, 50, 50), Color.White);
        _spriteBatch.End();
        base.Draw(gameTime);
    }
}