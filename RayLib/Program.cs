﻿using Raylib_cs;
using ComponentBasedGame.Components;
using ComponentBasedGame.Entities;

Raylib.InitWindow(800, 480, "Hello World");



var EntityManager = new ComponentBasedGame.EntityManager();

var Entity = new Entity();
Entity.AddComponent(new TransformCompoment() { Position = new System.Numerics.Vector2(300, 400), Speed=100 });
var image = Raylib.LoadImage("Resources\\Texture\\WirelessDisplay.png");
Entity.AddComponent(new DrawableTextureComponent() { Texture2D = Raylib.LoadTextureFromImage(image), T_Int = Color.BLUE }); 
Entity.AddComponent(new PlayerInputComponent());
EntityManager.Register(Entity);


while (!Raylib.WindowShouldClose())
{
    var elapsedTime = Raylib.GetFrameTime();
    EntityManager.BeforeDraw(elapsedTime);

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

    EntityManager.Draw(elapsedTime);

    Raylib.DrawText(Raylib.GetFPS().ToString(), 12, 12, 20, Color.BLACK);

    Raylib.EndDrawing();

    EntityManager.AfterDraw(elapsedTime);
}

Raylib.CloseWindow();