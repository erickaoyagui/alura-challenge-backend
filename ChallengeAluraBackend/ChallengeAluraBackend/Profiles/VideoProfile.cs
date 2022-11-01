using AutoMapper;
using ChallengeAluraBackend.Data.Dtos;
using ChallengeAluraBackend.Models;

namespace ChallengeAluraBackend.Profiles
{
    public class VideoProfile : Profile
    {
        public VideoProfile()
        {
            // <Source, Destination>
            CreateMap<CreateVideoDto, Video>();
            CreateMap<Video, ReadVideoDto>();
            CreateMap<Video, UpdateVideoDto>();
        }
    }
}
