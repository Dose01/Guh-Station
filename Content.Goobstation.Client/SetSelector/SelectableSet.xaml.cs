// SPDX-FileCopyrightText: 2025 GoobBot <uristmchands@proton.me>
// SPDX-FileCopyrightText: 2025 pheenty <fedorlukin2006@gmail.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Goobstation.Shared.SetSelector;
using Robust.Client.AutoGenerated;
using Robust.Client.GameObjects;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;

namespace Content.Goobstation.Client.SetSelector;

[GenerateTypedNameReferences]
public sealed partial class SelectableSet : Control
{
    public SelectableSet(SelectableSetInfo set, SpriteSystem spriteSystem)
    {
        RobustXamlLoader.Load(this);

        Icon.Texture = spriteSystem.Frame0(set.Sprite);
        SetName.Text = Loc.GetString(set.Name);
        SetDescription.Text = Loc.GetString(set.Description);
        SetButton.Text = Loc.GetString(set.Selected ? "set-selector-button-deselect" : "set-selector-button-select");
        SetButton.ModulateSelfOverride = set.Selected ? new Color(40, 84, 35) : new Color(68, 75, 103);
    }
}
