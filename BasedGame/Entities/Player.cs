﻿using BasedGame.Components;

namespace BasedGame.Entities;

internal class Enemy : Entity
{
    public ActorComponent ActorComponent { get; } = new();
}