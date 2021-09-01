using PersonalityTest.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalityTest.Business
{
    public class QuestionRepository
    {
        private List<Question> _questionsList;
        public QuestionRepository()
        {
            _questionsList = GetInitialQuestionsList();
        }

        public List<Question> Get()
        {
            return _questionsList;
        }


        private List<Question> GetInitialQuestionsList()
        {
            return new List<Question>
            {
                new Question
                {
                    Title ="You’re really busy at work and a colleague is telling you their life story and personal woes. You:",
                    Options = new string[] {
                        "Don’t dare to interrupt them",
                        "Think it’s more important to give them some of your time; work can wait",
                        "Listen, but with only with half an ear",
                        "Interrupt and explain that you are really busy at the moment"
                    }
                },
                new Question
                {
                    Title ="You’ve been sitting in the doctor’s waiting room for more than 25 minutes. You:",
                    Options = new string[] {
                        "Look at your watch every two minutes",
                        "Bubble with inner anger, but keep quiet",
                        "Explain to other equally impatient people in the room that the doctor is always running late",
                        "Complain in a loud voice, while tapping your foot impatiently"
                    }
                },
                new Question
                {
                    Title ="You’re having an animated discussion with a colleague regarding a project that you’re in charge of. You:",
                    Options = new string[] {
                        "Don’t dare contradict them",
                        "Think that they are obviously right",
                        "Defend your own point of view, tooth and nail",
                        "Continuously interrupt your colleague"
                    }
                },
                new Question
                {
                    Title ="You are taking part in a guided tour of a museum. You:",
                    Options = new string[] {
                        "Are a bit too far towards the back so don’t really hear what the guide is saying",
                        "Follow the group without question",
                        "Make sure that everyone is able to hear properly",
                        "Are right up the front, adding your own comments in a loud voice"
                    }
                },
                new Question
                {
                    Title ="During dinner parties at your home, you have a hard time with people who:",
                    Options = new string[] {
                        "Ask you to tell a story in front of everyone else",
                        "Talk privately between themselves",
                        "Hang around you all evening",
                        "Always drag the conversation back to themselves"
                    }
                },
                new Question
                {
                    Title ="You crack a joke at work, but nobody seems to have noticed. You:",
                    Options = new string[] {
                        "Think it’s for the best — it was a lame joke anyway",
                        "Wait to share it with your friends after work",
                        "Try again a bit later with one of your colleagues",
                        "Keep telling it until they pay attention"
                    }
                },
                new Question
                {
                    Title ="This morning, your agenda seems to be free. You:",
                    Options = new string[] {
                        "Know that somebody will find a reason to come and bother you",
                        "Heave a sigh of relief and look forward to a day without stress",
                        "Question your colleagues about a project that’s been worrying you",
                        "Pick up the phone and start filling up your agenda with meetings"
                    }
                },
                new Question
                {
                    Title ="During dinner, the discussion moves to a subject about which you know nothing at all. You:",
                    Options = new string[] {
                        "Don’t dare show that you don’t know anything about the subject",
                        "Barely follow the discussion",
                        "Ask lots of questions to learn more about it",
                        "Change the subject of discussion"
                    }
                },
                new Question
                {
                    Title ="You’re out with a group of friends and there’s a person who’s quite shy and doesn’t talk much. You:",
                    Options = new string[] {
                        "Notice that they’re alone, but don’t go over to talk with them",
                        "Go and have a chat with them",
                        "Shoot some friendly smiles in their direction",
                        "Hardly notice them at all"
                    }
                },
                new Question
                {
                    Title ="At work, somebody asks for your help for the hundredth time. You:",
                    Options = new string[] {
                        "Give them a hand, as usual",
                        "Accept — you’re known for being helpful",
                        "Ask them, please, to find somebody else for a change",
                        "Loudly make it known that you’re annoyed"
                    }
                },
                new Question
                {
                    Title ="You’ve been see a movie with your family and the reviews are mixed. You:",
                    Options = new string[] {
                        "Don’t share your point of view with anyone",
                        "Didn’t like the film, but keep your views to yourself when asked",
                        "State your point of view with enthusiasm",
                        "Try to bring the others round to your point of view"
                    }
                },
                new Question
                {
                    Title ="A friend arrives late for your meeting. You:",
                    Options = new string[] {
                        "Say, ‘It’s not a problem,’ even if that’s not what you really think",
                        "Give them a filthy look and sulk for the rest of the evening",
                        "Tell them, ‘You’re too much! Have you seen the time?’",
                        "Make a scene in front of everyone"
                    }
                },
                new Question
                {
                    Title ="You can’t find your car keys. You:",
                    Options = new string[] {
                        "Don’t want anyone to find out, so you take the bus instead",
                        "Panic and search madly without asking anyone for help",
                        "Grumble without telling your family why you’re in a bad mood",
                        "Accuse those around you for misplacing them"
                    }
                },
                new Question
                {
                    Title ="It’s time for your annual appraisal with your boss. You:",
                    Options = new string[] {
                        "Go with great hesitation as these sessions are torture for you",
                        "Look forward to hearing what your boss thinks about you and expects from you",
                        "Rehearse ad nauseam the arguments and ideas that you’ve prepared for the meeting",
                        "Go along unprepared as you are confident and like improvising"
                    }
                }
            };
        }
    }
}