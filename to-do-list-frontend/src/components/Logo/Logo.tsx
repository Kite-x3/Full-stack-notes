export const Logo = ({ className = '' }) => {
  return (
    <svg
      className={className}
      width='256px'
      height='256px'
      viewBox='0 0 1000 1000'
      xmlns='http://www.w3.org/2000/svg'
      fill='currentColor'
    >
      <g>
        <path
          className='logo-stroke'
          d='M595.65,590.07V694.4a40.1,40.1,0,0,1-40,40H283.93a40.11,40.11,0,0,1-40-40V305.6a40.11,40.11,0,0,1,40-40H555.66a40.1,40.1,0,0,1,40,40V409.93'
        />
        <path
          className='logo-stroke'
          d='M726.55,374.22h0a29.51,29.51,0,0,1,29.51,29.51v29.51a0,0,0,0,1,0,0H697a0,0,0,0,1,0,0V403.73A29.51,29.51,0,0,1,726.55,374.22Z'
          transform='translate(579.02 -414.26) rotate(50.72)'
        />
        <path
          className='logo-stroke'
          d='M685,399.57,465.66,579.25a2.19,2.19,0,0,0-.76,1.25l-9.8,45.28,46.32-.63a2.17,2.17,0,0,0,1.38-.5l219.6-179.4Z'
        />
      </g>
    </svg>
  )
}
