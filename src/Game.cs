using Raylib_cs;
using static Raylib_cs.Raylib;

namespace BlobRay;

class Game
{
    public static void Run()
    {
        InitWindow(800, 480, "Blob Ray");
        InitAudioDevice();
        SetWindowIcon(LoadImage("assets/icon.png"));

        //SetTargetFPS(60);

        Texture2D player = LoadTexture("assets/player.png");
        Sound yipee = LoadSound("assets/success.wav");

        while (!WindowShouldClose()) //! Main Loop
        {
            BeginDrawing();
            ClearBackground(Color.White);

            if(IsKeyDown(KeyboardKey.Space))
            {
                DrawText("Hello, space!", 12, 12, 32, Color.Blue);
            } else {
                DrawText("Hello, world!", 12, 12, 32, Color.Black);
            }

            if(IsKeyPressed(KeyboardKey.Space))
            {
                PlaySound(yipee);
            }

            DrawText(IsTextureValid(player).ToString(), 12, 200, 32, Color.Black);

            DrawRectangle(12, 100, 100, 50, Color.Black);
            DrawText("BOX", 18, 104, 44, Color.White);
            DrawTexture(player, 12, 250, Color.White);

            DrawText("FPS: " + GetFPS().ToString(), 12, 350, 32, Color.Black);

            EndDrawing();
        }

        CloseWindow();
    }
}