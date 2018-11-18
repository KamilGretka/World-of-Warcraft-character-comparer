﻿using System.Collections.Generic;
using WowCharComparerWebApp.Models.CharacterProfile;
using WowCharComparerWebApp.Models.Mappers;

namespace WowCharComparerWebApp.Logic.Character.AchievementPoints
{
    public class AchievementPointsComparer
    {
        public static CharacterAchievementPointsCompareResult CompareAchievementPoints(List<CharacterModel> parsedResultList)
        {
            int achievementPointResult = parsedResultList[0].AchievementPoints > parsedResultList[1].AchievementPoints
                                                     ? parsedResultList[0].AchievementPoints - parsedResultList[1].AchievementPoints
                                                     : parsedResultList[1].AchievementPoints - parsedResultList[0].AchievementPoints;

            return new CharacterAchievementPointsCompareResult()
            {
                AchievementPointsDifferance = achievementPointResult
            };
        }
    }
}
