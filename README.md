ImgurNet
========

imgur wrapper in .NET (currently work in progress)

## Usage
```csharp
 var imgur = new ImgurApi("CLIENT_ID", "CLIENT_SECRET");
 
 var result = await imgur.ImageDetails("IMAGE_ID");
 
```

## Example of file upload using ASP.NET MVC
```csharp
public async Task<string> FileUpload(HttpPostedFileBase picture)
{
    var CLIENT_ID = "CLIENT_ID";
    var CLIENT_SECRET = "CLIENT_SECRET";

    // create instance of ImgurApi
    var imgur = new ImgurApi(CLIENT_ID, CLIENT_SECRET);
  
    using (var ms = new MemoryStream())
    {
        picture.InputStream.CopyTo(ms);
        byte[] array = ms.GetBuffer();

        // create image upload object 
        var image = new ImageUpload(ImageUploadType.File)
        {
            Image = array,
            Title = "uploaded using ASP.NET MVC",
            Description = "this API wrapper is currently a work in progress by kimerran..."
        };

        // call ImageUpload()
        var result = await imgur.ImageUpload(image);

        return result.Id;
    }
}
```
See the uploaded picture here : http://imgur.com/1dEGVGj

## How to contribute

1. git clone https://github.com/kimerran/ImgurNet.git
2.  Build (using Visual Studio 2013 or later)
3.  Implement the API (https://api.imgur.com)
4.  Submit PULL requests

## Found bugs?
Please open a new issue


Thanks!
