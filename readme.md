<p align="center"><img src="img/large.png" width="60%"></p>

<p align="center">
<a href="https://github.com/senhungwong/unity-health-bar/blob/master/LICENSE"><img alt="License" src="https://img.shields.io/github/license/senhungwong/unity-health-bar.svg?style=flat-square"></a>
<a href="https://github.com/senhungwong/unity-health-bar/tags"><img alt="GitHub tag" src="https://img.shields.io/github/tag/senhungwong/unity-health-bar.svg?style=flat-square"></a>
<a href="http://u3d.as/1nts"><img alt="Unity Assets Store" src="https://img.shields.io/badge/store-unity assets store-ff69b4.svg?style=flat-square"></a>
</p>

## Description

A prefab that shows a character's health.

## Demo

![](img/demo.gif)

## How to use

1. Drag the prefab into the `Hierarchy`.

2. Make sure an `EventSystem` exists in the `Hierarchy`. (If not, you can create one by creating a `canvas` element then delete it)

3. Set health

```cs
public float maxHealth;
public float currentHealth;

public HealthBar healthBar;

private void Start() {
    healthBar.SetMaxHealth(maxHealth);
    healthBar.SetCurrentHealth(currentHealth);
}
```

4. Update current health when damaged or healed

```cs
currentHealth -= damage;
healthBar.SetCurrentHealth(currentHealth);
```

## Video

```
// TODO: Add a tutorial video while there are plenty enough types of health bars
```

## Unity assets store

http://u3d.as/1nts
