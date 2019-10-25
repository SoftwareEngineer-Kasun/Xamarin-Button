        Button button = FindViewById<Button> (Resource.Id.btnOne);

        button.Click += delegate {
          button.Text = string.Format ("{0} clicks!", count++);
        };
