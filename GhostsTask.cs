using System;
using System.Text;

namespace hashes
{
	public class GhostsTask :
		IFactory<Document>, IFactory<Vector>, IFactory<Segment>, IFactory<Cat>, IFactory<Robot>,
		IMagic
	{
		Cat cat;
		Document document;
		byte[] fordocument = Encoding.ASCII.GetBytes("It's a doc");
		byte[] hacker = Encoding.ASCII.GetBytes("I'm hacker");
		Vector vector;
		Segment segment;
		Robot robot;

		public void DoMagic()
		{
			cat?.Rename("Ghostcat");
			Robot.BatteryCapacity = 100500;
			vector?.Add(vector);
			segment?.Start?.Add(segment.Start);
			if (document != null)
				for (int i = 0; i < fordocument.Length; i++)
					fordocument[i] = hacker[i];
		}

		Vector IFactory<Vector>.Create()
		{
			if (vector == null)
				vector = new Vector(42, 42);
			return vector;
		}

		Segment IFactory<Segment>.Create()
		{
			if (segment == null)
				segment = new Segment(new Vector(42, 42), new Vector(42, 42));
			return segment;
		}

		Document IFactory<Document>.Create()
		{
			if (document == null)
				document = new Document("CoolDoc", Encoding.UTF8, fordocument); ;
			return document;
		}

		Cat IFactory<Cat>.Create()
		{
			if (cat == null)
				cat = new Cat("Nyashka", "cool", DateTime.Now);
			return cat;
		}

		Robot IFactory<Robot>.Create()
		{
			Robot.BatteryCapacity = 100;
			if (robot == null)
				robot = new Robot("42");
			return robot;
		}
	}
}