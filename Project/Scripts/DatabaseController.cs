using Godot;
using System;
using Project.Database;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

public partial class DatabaseController : Node
{
	private PrimaryDatabaseContext _primaryDatabaseContext;
	private RichTextLabel _richTextLabel;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_primaryDatabaseContext = new PrimaryDatabaseContext();
		_richTextLabel = GetNode<RichTextLabel>("Control/RichTextLabel");
        DoQuery();
	}

	private async void DoQuery()
	{
		var pizza = await _primaryDatabaseContext.Foods.FirstOrDefaultAsync(f => f.Name == "Pizza");

		if (pizza is null)
		{
			_richTextLabel.AddText($"Unable to find pizza! :(");
			return;
		}

		_richTextLabel.AddText($"Found Pizza! Id is -> {pizza.Id}");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
