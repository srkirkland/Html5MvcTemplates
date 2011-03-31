## Html5 Object Templates for ASP.NET MVC 3.

For setup instructions, see the [Setup And Getting Started](https://github.com/srkirkland/Html5MvcTemplates/wiki/Setup-And-Getting-Started) page.

This project adds the new html5 input types, such as email, tel, and url, to the MVC EditorTemplates.

For example, assume you have a person class:

	public class Person {
	    public string Name {get;set;}

	    [DataType(DataType.Email)]
	    public string Email {get;set;}

	    [DataType(DataType.Url)]
	    public string Url {get;set;}
	}

By default in ASP.NET MVC, calling `Html.EditorFor()` on any of these properties will create a simple `<input type='text' ... />` tag.

This project creates simple EditorTemplates which allow an `Html.EditorFor()` call to create the proper Html5 input types, such as `Html.EditorFor(p=>p.Email)` resulting in `<input type='email' ... />`.

So the relevant part of calling `Html.EditorFor(Model)` would give:

	<input type="text" id="Name" name="Name" />
	<input type="email" id="Email" name="Email" />
	<input type="url" id="Url" name="Url" />

The great thing about the new Html5 input types is that old browsers have no problem displaying them (they just default to type='text').  Modern browsers, however, can use them to create a better user experience.  This better experience may come from validation or styling (for example, Opera puts a small email icon inside the field), and many mobile devices (like the iPhone) will recognize these new types and display a customized keyboard.

There really isn't any downside to converting your basic `<input type='text' .../>` tags to new html5 input types for known data types, as the users that have modern browsers will enjoy the benefits without damaging the experience for legacy browsers.

Status:

This project currently adds Mvc Editor Templates for the following new HTML5 input types:

* search
* tel
* url
* email
* datetime
* date
* month
* week
* time
* datetime-local
* number
* range
* color

The only input type not supported is range, and that is because having a range input doesn't make any sense without being able to specify a min/max for that range.

### Links:
For a list of html input types, see: [[http://www.whatwg.org/specs/web-apps/current-work/multipage/the-input-element.html#attr-input-type]]

For a good reference on html5 form changes, see: [[http://diveintohtml5.org/forms.html]]