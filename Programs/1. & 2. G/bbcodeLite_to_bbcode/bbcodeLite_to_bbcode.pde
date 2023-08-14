import g4p_controls.*;

GTextArea input_txa;
GTextArea output_txa;

int i;
// https://osu.ppy.sh/wiki/en/BBCode#tags

//arguments
    
    String hexcode = "", number = "", name = "", link = "", userid = "", address = "";
//tags
    String bold          , bold_start =             "[b]"                       , bold_end = "[/b]";
    String italic        , italic_start =           "[i]"                       , italic_end = "[/i]";
    String underline     , underline_start =        "[u]"                       , underline_end = "[/u]";
    String strikethrough , strikethrough_start =    "[strike]"                  , strikethrough_end = "[/strike]";
    String colour        , colour_start =           "[color]"                   , colour_end = "[/color]";
    String fontSize      , fontSize_start =         "[size]"                    , fontSize_end = "[/size]";
    String spoiler       , spoiler_start =          "[spoiler]"                 , spoiler_end = "[/spoiler]";
    String box           , box_start =              "[box="                     , box_end = "[/box]";
    String spoilerbox    , spoilerbox_start =       "[spoilerbox]"              , spoilerbox_end = "[/spoilerbox]";
    String quote         , quote_start =            "[quote]"                   , quote_end = "[/quote]";
    String code          , code_start =             "[code]"                    , code_end = "[/code]";
    String centre        , centre_start =           "[centre]"                  , centre_end = "[/centre]";
    String url           , url_start =              "[url]"                     , url_end = "[/url]";
    String profile       , profile_start =          "[profile]"                 , profile_end = "[/profile]";
    String list          , list_start =             "[list]"                    , list_end = "[/list]";
    String email         , email_start =            "[email]"                   , email_end = "[/email]";
    String img           , img_start =              "[img]"                     , img_end = "[/img]";
    String youtube       , youtube_start =          "[youtube]"                 , youtube_end = "[/youtube]";
    String audio         , audio_start =            "[audio]"                   , audio_end = "[/audio]";
    String heading       , heading_start =          "[heading]"                 , heading_end = "[/heading]";
    String notice        , notice_start =           "[notice]"                  , notice_end = "[/notice]";
    String dot = "[*]";


void setup() {
    background(25);
    size(1080, 720);

    input_txa = new GTextArea(this, 0, 0, width/2, height);
    output_txa = new GTextArea(this, width/2, 0, width/2, height);

}

void draw() {
    tags();
    bbcode_lite();
    
}

void tags() {
    
    bold            = bold_start          + "\n" +" "+ "\n" + bold_end;
    italic          = italic_start        + "\n" +" "+ "\n" + italic_end;
    underline       = underline_start     + "\n" +" "+ "\n" + underline_end;
    strikethrough   = strikethrough_start + "\n" +" "+ "\n" + strikethrough_end;
    colour          = colour_start        + "\n" +" "+ "\n" + colour_end;
    fontSize        = fontSize_start      + "\n" +" "+ "\n" + fontSize_end;
    spoiler         = spoiler_start       + "\n" +" "+ "\n" + spoiler_end;
    box             = box_start + name +"]" + "\n" +" "+ "\n" + box_end;
    spoilerbox      = spoilerbox_start    + "\n" +" "+ "\n" + spoilerbox_end;
    quote           = quote_start         + "\n" +" "+ "\n" + quote_end;
    code            = code_start          + "\n" +" "+ "\n" + code_end;
    centre          = centre_start        + "\n" +" "+ "\n" + centre_end;
    url             = url_start           + "\n" +" "+ "\n" + url_end;
    profile         = profile_start       + "\n" +" "+ "\n" + profile_end;
    list            = list_start          + "\n" +" "+ "\n" + list_end;
    email           = email_start         + "\n" +" "+ "\n" + email_end;
    img             = img_start           + "\n" +" "+ "\n" + img_end;
    youtube         = youtube_start       + "\n" +" "+ "\n" + youtube_end;
    audio           = audio_start         + "\n" +" "+ "\n" + audio_end;
    heading         = heading_start       + "\n" +" "+ "\n" + heading_end;
    notice          = notice_start        + "\n" +" "+ "\n" + notice_end;
}

void bbcode_lite() {
    
    name = "test";

    String output_text = input_txa.getText()
    .replace("-", "\n")
    .replace("bold ", bold)
    .replace("italic ", italic)
    .replace("underline ", underline)
    .replace("strikethrough ", strikethrough)
    .replace("colour ", colour)
    .replace("fontSize ", fontSize)
    .replace("spoiler ", spoiler)
    .replace("box ", box)
    .replace("spoilerbox ", spoilerbox)
    .replace("quote ", quote)
    .replace("code ", code)
    .replace("centre ", centre)
    .replace("url ", url)
    .replace("profile ", profile)
    .replace("list ", list)
    .replace("email ", email)
    .replace("img ", img)
    .replace("youtube ", youtube)
    .replace("audio ", audio)
    .replace("heading ", heading)
    .replace("notice ", notice)
    ;

    output_txa.setText(output_text);
}