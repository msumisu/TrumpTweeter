﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpTweeter.Json
{
    public class Data2
    {
        public string domain { get; set; }
        public object approved_at_utc { get; set; }
        public object banned_by { get; set; }
        public MediaEmbed media_embed { get; set; }
        public int? thumbnail_width { get; set; }
        public string subreddit { get; set; }
        public string selftext_html { get; set; }
        public string selftext { get; set; }
        public object likes { get; set; }
        public object suggested_sort { get; set; }
        public List<object> user_reports { get; set; }
        public SecureMedia secure_media { get; set; }
        public string link_flair_text { get; set; }
        public string id { get; set; }
        public object banned_at_utc { get; set; }
        public object view_count { get; set; }
        public bool archived { get; set; }
        public bool clicked { get; set; }
        public object report_reasons { get; set; }
        public string title { get; set; }
        public Media media { get; set; }
        public List<object> mod_reports { get; set; }
        public bool can_mod_post { get; set; }
        public string author_flair_text { get; set; }
        public int score { get; set; }
        public object approved_by { get; set; }
        public bool over_18 { get; set; }
        public bool hidden { get; set; }
        public Preview preview { get; set; }
        public string thumbnail { get; set; }
        public string subreddit_id { get; set; }
        public bool edited { get; set; }
        public string link_flair_css_class { get; set; }
        public string author_flair_css_class { get; set; }
        public bool contest_mode { get; set; }
        public int gilded { get; set; }
        public int downs { get; set; }
        public bool brand_safe { get; set; }
        public SecureMediaEmbed secure_media_embed { get; set; }
        public bool saved { get; set; }
        public object removal_reason { get; set; }
        public string post_hint { get; set; }
        public bool stickied { get; set; }
        public bool can_gild { get; set; }
        public int? thumbnail_height { get; set; }
        public string parent_whitelist_status { get; set; }
        public string name { get; set; }
        public bool spoiler { get; set; }
        public string permalink { get; set; }
        public string subreddit_type { get; set; }
        public bool locked { get; set; }
        public bool hide_score { get; set; }
        public double created { get; set; }
        public string url { get; set; }
        public string whitelist_status { get; set; }
        public bool quarantine { get; set; }
        public string author { get; set; }
        public double created_utc { get; set; }
        public string subreddit_name_prefixed { get; set; }
        public int ups { get; set; }
        public int num_comments { get; set; }
        public bool is_self { get; set; }
        public bool visited { get; set; }
        public object num_reports { get; set; }
        public bool is_video { get; set; }
        public object distinguished { get; set; }
    }
}
