using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThreatLockerWebUI.LiveChat
{
    public class ChatDataFromLiveChat
    {
        public string id { get; set; }
        public List<User> users { get; set; }
        public Thread thread { get; set; }
        public Properties properties { get; set; }
        public Access access { get; set; }
        public bool is_followed { get; set; }
    }

    public class User
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime events_seen_up_to { get; set; }
        public string type { get; set; }
        public bool present { get; set; }
        public DateTime created_at { get; set; }
        public List<SessionField> session_fields { get; set; }
        public LastVisit last_visit { get; set; }
        public Statistics statistics { get; set; }
        public DateTime agent_last_event_created_at { get; set; }
        public DateTime customer_last_event_created_at { get; set; }
        public string avatar { get; set; }
    }

    public class Thread
    {
        public string id { get; set; }
        public bool active { get; set; }
        public List<string> user_ids { get; set; }
        public Properties properties { get; set; }
        public Access access { get; set; }
        public string previous_thread_id { get; set; }
        public DateTime created_at { get; set; }
        public List<Event> events { get; set; }
    }

    public class Event
    {
        public string id { get; set; }
        public DateTime created_at { get; set; }
        public string recipients { get; set; }
        public string type { get; set; }
        public Properties properties { get; set; }
        public string author_id { get; set; }
        public string custom_id { get; set; }
        public string form_id { get; set; }
        public List<Field> fields { get; set; }
        public string text { get; set; }
        public string system_message_type { get; set; }
        public TextVars text_vars { get; set; }
    }

    public class Field
    {
        public string id { get; set; }
        public string type { get; set; }
        public string label { get; set; }
        public object answer { get; set; }
    }

    public class TextVars
    {
        public string customer { get; set; }
    }

    public class Access
    {
        public List<int> group_ids { get; set; }
    }

    public class Properties
    {
        public Routing routing { get; set; }
        public Source source { get; set; }
        public Lc2 lc2 { get; set; }
        public Supervising supervising { get; set; }
    }

    public class Routing
    {
        public bool continuous { get; set; }
        public string group_status_at_start { get; set; }
        public bool idle { get; set; }
        public int last_transfer_timestamp { get; set; }
        public string referrer { get; set; }
        public string start_url { get; set; }
        public bool unassigned { get; set; }
        public bool pinned { get; set; }
        public bool was_pinned { get; set; }
    }

    public class Source
    {
        public string client_id { get; set; }
        public string customer_client_id { get; set; }
    }

    public class Lc2
    {
        public string form_type { get; set; }
        public bool? welcome_message { get; set; }
    }

    public class Supervising
    {
        public string agent_ids { get; set; }
    }

    public class SessionField
    {
        public string Organization { get; set; }
        public string __details_json { get; set; }
    }

    public class LastVisit
    {
        public DateTime started_at { get; set; }
        public string referrer { get; set; }
        public string ip { get; set; }
        public string user_agent { get; set; }
        public Geolocation geolocation { get; set; }
        public List<LastPage> last_pages { get; set; }
    }

    public class Geolocation
    {
        public string country { get; set; }
        public string country_code { get; set; }
        public string region { get; set; }
        public string city { get; set; }
        public string timezone { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public class LastPage
    {
        public DateTime opened_at { get; set; }
        public string url { get; set; }
        public string title { get; set; }
    }

    public class Statistics
    {
        public int chats_count { get; set; }
        public int threads_count { get; set; }
        public int visits_count { get; set; }
        public int page_views_count { get; set; }
        public int greetings_shown_count { get; set; }
        public int greetings_accepted_count { get; set; }
    }
}
