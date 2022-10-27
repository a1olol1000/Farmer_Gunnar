using Raylib_cs;

Raylib.InitWindow(800,600, "Farmer Gunnar");
Raylib.SetTargetFPS(60);



List<Enemy> enemies = new List<Enemy>();

enemies.Add(new Enemy());
enemies.Add(new Enemy());
enemies.Add(new Enemy());

enemies[1].rect.x=300;
enemies[2].rect.x=700;

while (!Raylib.WindowShouldClose())
{
    //log

    foreach (Enemy e in enemies)
    {
        e.rect.y++;
    }

    //graph
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLACK);

    foreach (Enemy e in enemies)
    {
        e.Draw();
    }


   
    


    Raylib.EndDrawing();
}