using System.Collections.Generic;

namespace GameHangman
{
    //changing of the hangman images
    public class HangmanPictureAnimator
    {
        private List<int> ResourceList { get; set; }
        private int Count { get; set; }

        public bool EndOfResources { get; set; }

        public HangmanPictureAnimator()
        {
            ResourceList = new List<int>();
            ResourceList.Add(Resource.Drawable.hanger);
            ResourceList.Add(Resource.Drawable.hangman1);
            ResourceList.Add(Resource.Drawable.hangman2);
            ResourceList.Add(Resource.Drawable.hangman3);
            ResourceList.Add(Resource.Drawable.hangman4);
            ResourceList.Add(Resource.Drawable.hangman5);
            ResourceList.Add(Resource.Drawable.hangman6);
            ResourceList.Add(Resource.Drawable.hangman7);
            Count = 0;
            EndOfResources = false;
        }

        //Gets next image.
        public int GetNextResource()
        {
            var id = ResourceList[Count];
            Count++;
            if (Count >= ResourceList.Count)
            {
                EndOfResources = true;
            }
            return id;
        }
    }
}
