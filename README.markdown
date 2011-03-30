Html5 Object Templates for ASP.NET MVC 2 and 3.

Will add the new html5 input types, such as email, tel, and url, to the MVC EditorTemplates.

For example, assume you have a person class:

	public class Person {
	    public string Name {get;set;}

	    [DataType(DataType.Email)]
	    public string Email {get;set;}

	    [DataType(DataType.Url)]
	    public string Url {get;set;}
	}

By default in ASP.NET MVC, calling Html.EditorFor() on any of these properties will create a simple `<input type='text' ... />` tag.

This project intends to have Html.EditorFor() call the proper Html5 input types, such as Html.EditorFor(p=>p.Email) resulting in `<input type='Email' ... />`.

The great thing about the new Html5 input types is that old browsers have no problem displaying them (they just default to type='text').  Modern browsers, however, can use them to create a better user experience.  This better experience may come from validation or styling (for example, Opera puts a small email icon inside the field), and many mobile devices (like the iPhone) will recognize these new types and display a customized keyboard.

There really isn't any downside to converting your basic `<input type='text' .../>` tags to new html5 input types for known data types, as the users that have modern browsers will enjoy the benefits without damaging the experience for legacy browsers.

Links:
For a list of html input types, see: http://www.whatwg.org/specs/web-apps/current-work/multipage/the-input-element.html#attr-input-type

For a good reference on html5 form changes, see: http://diveintohtml5.org/forms.html