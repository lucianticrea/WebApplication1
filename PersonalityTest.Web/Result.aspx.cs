﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PersonalityTest.Web
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["IsIntrovert"] == "True")
            {
                lblHeaderTitle.Text = "You are more of an introvert";
                lblResult.Text = "You feel that living alone is to live happily, and you prefer hiding in a crowd rather than standing out in one. You are perpetually tormented by the idea of doing things wrong, not understanding or not being alert enough or intelligent enough to do what others expect of you. You lack in self-confidence and you seem to believe that others are better than you. While in a conversation, for example, you would be more likely to go along with the other’s points of view as you don’t fully respect your own opinions. Where there’s a low level task to complete or a service to be allotted, it’s you who volunteers. When people want to get out of a task, they naturally come to you as they know that you never say ‘no’. It’s not surprising that you sometimes have the impression of being permanently exploited, but you don’t really know how to break this vicious circle. On the rare occasions that you’ve tried to do so, this uncharacteristic defiance has caused uproar and you’ve ended up backing down. You are afraid of contact with others as you imagine that they are constantly judging you and that their probing looks will obviously find your faults. So, you try to remain the most transparent and discreet possible. How far will you take this logic of self-denigration? Try and stop projecting onto others the bad image you have about yourself. Have a good look around you and you’ll see that they too have faults, weaknesses and shortcomings, so stop finding excuses for everything. Maybe you were brought up in an atmosphere of ‘You’ll never make the grade’ as a child — a poison that you need progressively to get out of your system. Learn to look after your own interests — everyone else does, so why not you? You too have desires, dreams and opinions — express them. If you think that by saying no or thinking differently from others that you will no longer be loved, it just isn’t so. Others will learn to respect you because you respect yourself.";
            }
            else
            {
                lblHeaderTitle.Text = "You are more of an extrovert";
                lblResult.Text = "Whether at work or at home, you are a leader, the head of the pack. You are the type of person who is at ease with everyone — with the grocer, the doctor, a managing director or a waiter. You have an opinion about just about everything and you like to share your knowledge around, even imposing it on others if they haven’t asked for it. Your personal and professional entourages easily class you as a ‘loud mouth’, sure about yourself, not in the least bit bothered about what others think of you and someone who occasionally likes to play the card of provocation. When you’re on a roll, it’s hard to sop you and the least that could be said is that listening skills are not one of your innate skills. In the couples arena, you have maybe fallen for someone with a similar temperament – making for animated evenings! Or on the contrary, you live with a more introverted partner over whom you can, in some cases, have the upper hand. Your confidence and exuberance are a strong motor for your highly colourful life and you are a real antidote to any hint of grey skies or boredom. It’s perhaps the moments of excess activity or confidence that you need to question. Your capacity to be over the top can make others feel that you consider yourself as the most important person, that you have to be the centre of attention to feel loved and thus to exist, unless of course these are ways of pre-empting judgement from others. Do you worry about leaving others indifferent if you’re not perpetually ‘on show’? Maybe this need for attention is to compensate your own self-judgement? Your energy levels and enthusiasm are unquestionable, but are you as comfortable receiving as giving? Have you actually listened to anyone recently, without butting in? Do you know how to stay by yourself and do nothing else but be with yourself? A few questions that could be interesting to ask yourself…";
            }
        }
    }
}