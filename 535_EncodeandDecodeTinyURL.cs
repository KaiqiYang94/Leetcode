public class Codec {
    private Dictionary<string, string> encodeUrls = new Dictionary<string, string>();
    private Dictionary<string, string> decodeUrls = new Dictionary<string, string>();
    
    private string shortPrefix = "http://tinyurl.com/";
    
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        StringBuilder str = new StringBuilder();
        if(!encodeUrls.Keys.Contains(longUrl))
        {
            string shortenUrl = encodeUrls.Keys.Count.ToString();
            encodeUrls.Add(longUrl, shortenUrl);
            decodeUrls.Add(shortenUrl, longUrl);
        }
        return str.Append(shortPrefix).Append(encodeUrls[longUrl]).ToString();
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        string url = shortUrl.Substring(shortPrefix.Count());
        return decodeUrls[url];
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));